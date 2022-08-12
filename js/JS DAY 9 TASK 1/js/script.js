function get() {
  var text = document.getElementById("text").value;
  var tel = document.getElementById("tel").value;
  var email = document.getElementById("e-mail").value;
  var msg = document.getElementById("message").value;
  alert("Your Name is " + text + "Your phone is " + tel + "Your Email is " + email + "Your msg is " + msg);
  console.log("done");
}
