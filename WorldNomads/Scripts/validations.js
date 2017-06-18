
function validateWholeNumber(evt){
    var key = window.event ? event.keyCode : event.which;
    var stat=false;
    if (key === 8) {
        stat=true;
    } else if ( key < 48 || key > 57 ) {
        stat=false;;
    } else {
        stat=true;;
    }
    return stat;
}
