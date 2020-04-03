function SaveMessage(firstname,lastname) {
    //alert(firstname + '  ' + lastname + " have been save successfully!");
    document.getElementById("divServerValidations")
        .innerText = firstname + '  ' + lastname + " have been save successfully!";
}

function setFocusOnElement(element) {
    element.focus();
}

function getCities() {

    //throw 'Something has gone wrong JS';

    var cities = ['New York', 'Los Angeles', 'Chicago', 'Houston', 'Phoenix', 'Philadelphia', 'San Antonio',
        'San Diego', 'Dallas', 'San Jose', 'Austin', 'Jacksonville', 'Fort Worth', 'Columbus', 'San Francisco',
        'Charlotte', 'Indianapolis', 'Seattle', 'Denver', 'Washington'];
    return cities;
}