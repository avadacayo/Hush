function body(state, mode, value) {

    switch (state) {

        case 0:
            ViewHandler.ShowImageDialog("http://c.thumbs.redditmedia.com/u8MK1Z85ECxMd0gt.png");
            break;

        default:
            ViewHandler.Close();
            break;

    }

}