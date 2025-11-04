function showAlert() {
  alert("Hello World");
}

function isLeapYear(year) {
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        return true;
    } else {
        return false;
    }
}

function checkLeapYear(selector) {
    const year = parseInt(document.querySelector(selector).value)

    const leap = isLeapYear(year);
    const message = leap ? `${year} is a Leap Year`: `${year} is not a Leap Year`;

    document.getElementById("result").innerText = message;
    console.log(message);
}