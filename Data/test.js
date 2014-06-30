function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowInputDialog("Enter In A Value:");
            break;

        case 1:
            ViewHandler.ShowTextDialog("You Entered: " + value);
            break;

        default:
            ViewHandler.Close();
            break;

    }

}