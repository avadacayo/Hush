var status = -1;

var captcha_link = "";
var captcha_value = "";
var success = false;
var current_page = "";
var login_hash = "";
var login_page = "";
var password_new = "";
var password_old = "";
var email = "";

function body(state, mode, value) {

    if (mode == 1) {
        status++;
    }
    else {
        ViewHandler.Close();
    }

    switch (status) {

        case 0:

            WebHandler.ClearCookies();

            email = AccessHandler.Access("email");
            password_old = AccessHandler.Access("password");

            login_page = WebHandler.SendGet(
                "http://members.000webhost.com/login.php"
            );

            captcha_link = get_captcha_url(login_page);

            ViewHandler.ShowImageDialog(WebHandler.DownloadImage("http://members.000webhost.com" + captcha_link));

            break;

        case 1:
            log("test");
            captcha_value = value;

            current_page = WebHandler.SendPost(
                "http://members.000webhost.com/login.php?action=login",
                "email=" + email.replace("@", "%40") +
                "&pass=" + password_old +
                "&number=" + captcha_value +
                "&button=Submit"
            );

            if (current_page.indexOf("<title>000webhost.com Members Area</title>") > -1) {

                login_hash = get_login_hash(current_page);

                WebHandler.SendGet(
                    "http://members.000webhost.com/edit_your_details.php?login_hash=" + login_hash
                );

                ViewHandler.ShowInputDialog("New Password:");
                success = true;

            }

            else {

                ViewHandler.ShowTextDialog("unable to login");

            }

            break;

        case 2:

            password_new = value;

            if (!success) {

                ViewHandler.Close();
                return;

            }

            current_page = WebHandler.SendPost(
                "http://members.000webhost.com/edit_your_details.php?&login_hash=" + login_hash + "&action=change_password",
                "old_pass=" + password_old +
                "&pass1=" + password_new +
                "&pass2=" + password_new +
                "&button2=Update+Password"
            );

            if (current_page.indexOf("<p>Your password has been updated successfully.</p>") > 1) {

                AccessHandler.Set("password", password_new);
                ViewHandler.ShowTextDialog("Your password has been updated!");
                return;

            }

            ViewHandler.ShowTextDialog("Unable to update password for unknown reasons.");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}

function get_captcha_url(login_page) {

    var regex = /src\=\"([^\"]+)\"\ id\=\"captcha\"/ig;
    var result = regex.exec(login_page);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}

function get_login_hash(any_page) {

    var regex = /\?login\_hash\=([a-zA-Z0-9]+)\"/ig;
    var result = regex.exec(any_page);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}