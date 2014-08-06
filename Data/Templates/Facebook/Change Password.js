// easier than i thought
// TEST DATA =
//  email: chizuomeretsu@gmail.com
//  pass: p@ssw0rd

var status = -1;
var fail = false;
var canLogin = true;
var temp = "";

var email = "";
var password = "";

var test = "";

function body(state, mode, value) {

    switch (state) {

        case 0:
            email = AccessHandler.Access("email");
            password = AccessHandler.Access("password");
            log("email=" + email);
            log("password=" + password);
            ViewHandler.ShowTextDialog("This script will change your Facebook account password.\n\nIs this ok?");
            break;

        case 1:
            if (email == "" || password == "") {
                fail = true;
                ViewHandler.ShowTextDialog("The \"email\" and \"password\" fields must be set.");
            }
            else {
                fail = false;
                login(email, password);
                test = checklogin();
                if (test != undefined && test != "") {
                    ViewHandler.ShowInputDialog("New password:");
                }
                else {
                    canLogin = false;
                    ViewHandler.ShowTextDialog("Unable to login with current information.");
                }
            }
            break;

        case 2:
            if (canLogin == false || fail == true) {
                ViewHandler.Close();
            }
            else {
                newPassword = value;
                changepassword(password, newPassword);
                login(email, newPassword);
                test = checklogin();
                if (test != undefined && test != "") {
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

function changepassword(oldpassword, newpassword) {

    var psswdhtml = WebHandler.SendGet("https://www.facebook.com/settings");

    var userid = get_userid(psswdhtml);
    var rev = get_rev(psswdhtml);
    var dtsg = get_dtsg(psswdhtml);

    var ret = WebHandler.SendPost(
        "https://www.facebook.com/ajax/settings/account/password.php",
        "password_old=" + oldpassword +
        "&password_new=" + newpassword + 
        "&password_confirm=" + newpassword +
        "&password_strength=3" + 
        "&__a=1" +
        "&__user=" + userid +
        "&__rev=" + rev +
        "&fb_dtsg=" + dtsg
    );

}

function login(email, password) {

    WebHandler.ClearCookies();
    WebHandler.SendGet("https://www.facebook.com/");

    var ret = WebHandler.SendPost(
        "https://www.facebook.com/login.php?login_attempt=1",
        "email=" + email + 
        "&pass=" + password
    );

}

function checklogin() {

    /*  temp test */
    var psswdhtml = WebHandler.SendGet("https://www.facebook.com/settings");

    var userid = get_userid(psswdhtml);
    var rev = get_rev(psswdhtml);
    var dtsg = get_dtsg(psswdhtml);

    if (userid != "" && rev != "" && dtsg != "") return userid;

    return "";

    /* old version */

    var html = WebHandler.SendGet("https://www.facebook.com/?sk=welcome");
    var regex = /headerTinymanName">([^\<]+)</ig;
    var result = regex.exec(html);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}

function get_dtsg(html) {

    var regex = /name\=\"fb_dtsg\"\ value\=\"([^\"]+)\"/ig;
    var result = regex.exec(html);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}

function get_rev(html) {

    var regex = /\"revision\"\:([^\,]+),/ig;
    var result = regex.exec(html);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}

function get_userid(html) {

    var regex = /id\=\"profile\_pic\_header\_([^\"]+)\"/ig;
    var result = regex.exec(html);

    if (result != undefined && result.length >= 2) {
        return result[1];
    }

    return "";

}
