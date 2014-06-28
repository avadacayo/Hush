function head() {
}

function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowTextDialog("testing\ntedfgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggsting 2\n");
            break;

        case 1:
            ViewHandler.ShowTextDialog("testing\ntesting 2\n testing3\ntesting5\n\n\n\n\n\nsdjfiojdfioosidfdf");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}