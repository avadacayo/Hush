var status = -1;

var pages = {
    form : "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin",
    action : "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin&action=submitlogin&type=login&returnto=Main_Page",
    pref: "http://zenit.senecac.on.ca/wiki/index.php/Special:Preferences",
};

function body(state, mode, value) {

    if (mode == 1) {
        status++;
    }
    else {
        ViewHandler.Close();
    }

    switch (status) {

        case 0:
            break;

        default:
            ViewHandler.Close();
            break;

    }

}

function getLoginToken() {

    var page = WebHandler.SendGet(pages.form);
    var regex = /name="wpLoginToken" value="([^"]+)"/ig;
    var result = regex.exec(page);

    if (result.length >= 2) {
        return result[1];
    }

    return false;

}