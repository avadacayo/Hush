var status = -1;

var captcha_link = "";
var captcha_value = "";
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

            email = "";
            password_old = "";

            login_page = WebHandler.SendGet(
                "http://members.000webhost.com/login.php"
            );

            captcha_link = get_captcha_url(login_page);

            //WebHandler.SendGet("http://members.000webhost.com" + captcha_link);
            ViewHandler.ShowImageDialog(WebHandler.DownloadImage("http://members.000webhost.com" + captcha_link));

            break;

        case 1:

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
                ViewHandler.ShowInputDialog("New Password");

            }

            else {

                ViewHandler.ShowTextDialog("unable to login");

            }

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

    var regex = /\/\?login\_hash\=([a-zA-Z0-9]+)\"/ig;
    var result = regex.exec(any_page);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}

//function checkLogin(pusername) {
//    var page = WebHandler.SendGet("http://www.crunchyroll.ca/");
//    var index = page.indexOf("\"/user/" + pusername + "\"");
//    return index > 0;
//}

//function changePassword() {
//    WebHandler.SendPost(
//        "https://www.crunchyroll.ca/?a=formhandler",
//        "formname=RpcApiUser_UpdateAcctInfo" +
//        "&next_url=/acct?action=emailpw" +
//        "&fail_url=/acct?action=emailpw" +
//        "&oldpw=" + password +
//        "&newpw1=" + newPassword +
//        "&newpw2=" + newPassword
//    );
//}