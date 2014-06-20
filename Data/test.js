var pages = {
	form : "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin",
	action : "http://zenit.senecac.on.ca/wiki/index.php?title=Special:UserLogin&action=submitlogin&type=login&returnto=Main_Page",
	pref: "http://zenit.senecac.on.ca/wiki/index.php/Special:Preferences",
};

function head() {
}

function body() {

	var loginToken;
	var zenitUsername = "";
	var zenitPassword = ""; 

	loginToken = getLoginToken();

	if (loginToken != false) {
		WebHandler.SendPost(pages.action, "wpName=" + zenitUsername + "&wpPassword=" + zenitPassword + "&wpLoginattempt=Log+in&wpLoginToken=" + loginToken);
		var content = WebHandler.SendGet(pages.pref);
		output(content.toString());
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