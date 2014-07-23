var status = -1;
var fail = false;
var canLogin = true;
var username = "";
var password = "";
var newPassword = "";

function body(state, mode, value) {

    if (mode == 1) {
        status++;
    }
    else {
        ViewHandler.Close();
    }

    switch (status) {

        case 0:
            username = AccessHandler.Access("username");
            password = AccessHandler.Access("password");
            ViewHandler.ShowTextDialog("This script will change your Crunchyroll account password.\n\nIs this ok?");
            break;

        case 1:
            if (username == "" || password == "") {
                fail = true;
                ViewHandler.ShowTextDialog("The \"username\" and \"password\" fields must be set.");
            }
            else {
                fail = false;
                submitLoginForm(username, password);
                if (checkLogin(username)) {
                    ViewHandler.ShowInputDialog("New password:");
                }
                else {
                    canLogin = false;
                    ViewHandler.ShowTextDialog("Unable to login.");
                }
            }
            break;

        case 2:
            if (canLogin == false || fail == true) {
                ViewHandler.Close();
            }
            else {
                newPassword = value;
                changePassword();
                WebHandler.ClearCookies();
                submitLoginForm(username, newPassword);
                if (checkLogin(username)) {
                    ViewHandler.ShowTextDialog("Your password has been changed!");
                    AccessHandler.Set("password", newPassword);
                }
                else {
                    ViewHandler.ShowTextDialog("Unable to change password.");
                }
            }
            break;

        default:
            ViewHandler.Close();
            break;

    }

}

function submitLoginForm(pusername, ppassword) {
    WebHandler.SendGet("https://www.crunchyroll.ca/");
    WebHandler.SendPost("https://www.crunchyroll.ca/?a=formhandler", "formname=RpcApiUser_Login&fail_url=http://www.crunchyroll.ca/login&name=" + pusername + "&password=" + ppassword);
}

function checkLogin(pusername) {
    var page = WebHandler.SendGet("http://www.crunchyroll.ca/");
    var index = page.indexOf("\"/user/" + pusername + "\"");
    return index > 0;
}

function changePassword() {
    WebHandler.SendPost(
        "https://www.crunchyroll.ca/?a=formhandler",
        "formname=RpcApiUser_UpdateAcctInfo" +
        "&next_url=/acct?action=emailpw" +
        "&fail_url=/acct?action=emailpw" +
        "&oldpw=" + password +
        "&newpw1=" + newPassword +
        "&newpw2=" + newPassword
    );
}