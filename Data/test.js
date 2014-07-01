function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowInputDialog("Enter In A Value:");
            break;

        case 1:
            if (value == "") {
                state = state - 2;
                ViewHandler.ShowTextDialog("Enter a value!");
            }
            else {
                ViewHandler.ShowTextDialog("You Entered: " + value);
            }
            break;

        default:
            ViewHandler.Close();
            break;

    }

}