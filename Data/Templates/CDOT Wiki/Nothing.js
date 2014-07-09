function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowDialog("This file does nothing.");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}