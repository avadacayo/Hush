var index = 0
var count = 0;
var fieldIndex = 0;

var name;
var value;

function body(state, mode, value) {

    if (mode == 1)
        index++;

    if (index == 1) {
        count = AccessHandler.Count();
    }

    if (count > 0 && fieldIndex < count) {
        name = AccessHandler.AccessNameByIndex(fieldIndex);
        value = AccessHandler.AccessValueByIndex(fieldIndex);
        ViewHandler.ShowTextDialog("Your \"" + name + "\" is \"" + value + "\"");
        fieldIndex++;
    }
    else {
        ViewHandler.Close();
    }

}