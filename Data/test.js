function head() {
}

function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowTextDialog("testing");
            break;

        case 1:
            ViewHandler.Close();
            break;

    }

}