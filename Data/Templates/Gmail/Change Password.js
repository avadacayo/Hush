var status = -1;
var fail = false;
var canLogin = true;
var temp = "";

var email = "";
var passwd = "";

var login_page = "";
var galx = "";

var test = "";
//
// GMAIL //
//
function body(state, mode, value) {

    switch (state) {

        case 0:
            email = AccessHandler.Access("Email");
            passwd = AccessHandler.Access("Passwd");
            log("Email=" + email);
            log("Passwd=" + passwd);
            ViewHandler.ShowTextDialog("This script will change your Gmail account password.\n\nIs this ok?");
            break;

        case 1:
            if (email == "" || passwd == "") {
                fail = true;
                ViewHandler.ShowTextDialog("The \"email\" and \"password\" fields must be set.");
            }
            else {
                fail = false;
                ViewHandler.ShowTextDialog("before login");
                login(email, passwd);
             //   test = checklogin();
                if (test != undefined && test != "") {
                    ViewHandler.ShowInputDialog("New password:");
                }
                else {
                    canLogin = false;
                    ViewHandler.ShowTextDialog("Unable to login with current information.");
                }
            }
            break;

        //case 2:
        //    if (canLogin == false || fail == true) {
        //        ViewHandler.Close();
        //    }
        //    else {
        //        newPassword = value;
        //        changepassword(password, newPassword);
        //        login(email, newPassword);
        //        test = checklogin();
        //        if (test != undefined && test != "") {
        //            ViewHandler.ShowTextDialog("Your password has been changed!");
        //            AccessHandler.Set("password", newPassword);
        //        }
        //        else {
        //            ViewHandler.ShowTextDialog("Unable to change password.");
        //        }
        //    }
        //    break;

        default:
            ViewHandler.Close();
            break;

    }

}

//function changepassword(oldpassword, newpassword) {



//}

function login(email, password) {

    WebHandler.ClearCookies();
    login_page = WebHandler.SendGet("https://accounts.google.com/ServiceLogin?sacu=1&scc=1&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&ss=1&ltmpl=default&rm=false");
    ViewHandler.ShowTextDialog("before galx");
    ViewHandler.ShowTextDialog(get_login_token(login_page));
    xx;
    ViewHandler.ShowTextDialog("galx = " + galx);
    xx;
    var ret = WebHandler.SendPost(
        "https://accounts.google.com/ServiceLoginAuth",
        "Email=" + email + 
        "&Passwd=" + password +
        "&GALX=" + galx
    );

}

function checklogin() {


}

function get_login_token(login_page) {

    var regex = /name\=\"GALX\"\ type\=\"hidden\"\ value\=\"[^\"]\"/ig;

    var result = regex.exec(login_page);
   
    if (result.length >= 2) {
        return result[1];
    }
    
    return "";

}