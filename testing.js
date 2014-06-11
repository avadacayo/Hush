// place this in bin\Debug\testing.js to have it found by the program

function head() {
	print("head!!");
	print(WebHandler.SendGet("http://www.google.ca"));
}

function body() {
	print("body!!");
}