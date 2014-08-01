var status = -1;

var success = false;
var current_page = "";
var login_token = "";
var login_page = "";
var password_new = "";
var password_old = "";
var password_token = "";
var username = "";

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

            username = AccessHandler.Access("username");
            password_old = AccessHandler.Access("password");

            login_page = WebHandler.SendGet(
                "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin"
            );

            login_token = get_login_token(login_page);

            login_page = WebHandler.SendPost(
                "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin&action=submitlogin&type=login&returnto=Main_Page",
                "wpName=" + encodeURIComponent(username).replace("%20", "+") +
                "&wpPassword=" + encodeURIComponent(password_old) +
                "&wpLoginattempt=Log+in" +
                "&wpLoginToken=" + login_token
            );

            if (login_page.indexOf("var wgUserName = \"" + username + "\";") > 1) {

                success = true;
                ViewHandler.ShowInputDialog("new password:");

            }

            else {

                ViewHandler.ShowTextDialog("Unable to login with current information.");
                success = false;

            }

            break;

        case 1:

            password_new = value;

            if (success == false) {

                ViewHandler.Close();
                return;

            }

            current_page = WebHandler.SendGet("http://zenit.senecac.on.ca/wiki/index.php?title=Special:ChangePassword&returnto=Special%3APreferences");
            password_token = get_password_token(current_page);

            WebHandler.SendPost(
                "http://zenit.senecac.on.ca/wiki/index.php/Special:ChangePassword",
                "token=" + encodeURIComponent(password_token) +
                "&wpName=" + encodeURIComponent(username).replace("%20", "+") +
                "&returnto=Special%3APreferences" +
                "&wpPassword=" + encodeURIComponent(password_old) +
                "&wpNewPassword=" + encodeURIComponent(password_new) +
                "&wpRetype=" + encodeURIComponent(password_new)
            );

            login_page = WebHandler.SendGet(
                "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin"
            );

            login_token = get_login_token(login_page);

            login_page = WebHandler.SendPost(
                "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin&action=submitlogin&type=login&returnto=Main_Page",
                "wpName=" + encodeURIComponent(username).replace("%20", "+") +
                "&wpPassword=" + encodeURIComponent(password_new) +
                "&wpLoginattempt=Log+in" +
                "&wpLoginToken=" + login_token
            );

            if (login_page.indexOf("var wgUserName = \"" + username + "\";") > 1) {

                AccessHandler.Set("password", password_new);
                ViewHandler.ShowTextDialog("Password changed!");
                return;

            }

            ViewHandler.ShowTextDialog("Unable to change password.");

            break;

        default:
            ViewHandler.Close();
            break;

    }

}

function get_login_token(login_page) {

    var regex = /name="wpLoginToken" value="([^"]+)"/ig;
    var result = regex.exec(login_page);

    if (result.length >= 2) {
        return result[1];
    }

    return false;

}

function get_password_token(login_page) {

    var regex = /name="token" type="hidden" value="([^"]+)"/ig;
    var result = regex.exec(login_page);

    if (result.length >= 2) {
        return result[1];
    }

    return false;

}