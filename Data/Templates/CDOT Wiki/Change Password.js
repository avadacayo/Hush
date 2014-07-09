var index = 0

function body(state, mode, value) {

    if (mode == 1)
        index++;

    switch (index) {

        case 0:
            ViewHandler.ShowDialog("Change Password!!!");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}