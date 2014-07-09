function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowDialog("Change Password!!!");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}