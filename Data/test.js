/*

the state parameter is currently unused

*/

var status = -1;

function body(state, mode, value) {

    if (mode == 1) {
        status++;
    }
    else {
        ViewHandler.Close();
    }

    switch (status) {

        default:
            ViewHandler.Close();
            break;

    }

}