// LABEL ANIMATION
const labels = document.querySelectorAll('.form-control label')

labels.forEach(
label => {
label.innerHTML = label.innerText
    .split('')
    .map(
            (letter, idx) => 
            `<span>${letter}</span>`
        )
    .join('')
}
)

// INPUT HANDLING


// Get rating value
function getRadioValue( radioArray ) {
    for ( let i = 0; i < radioArray.length; i++ ) {
       if ( radioArray[ i ].checked ) { 
          return radioArray[ i ].value;
       }
    }
    return "";
 }

// Function to check if required fields are empty
function checkFields() {
    var nameValue = document.getElementById("name").value;
    var emailValue = document.getElementById("email").value;
    var subjectValue = document.getElementById("subject").value;
    var messageValue = document.getElementById("message").value;

    var nameError = document.getElementById("name-error");
    var emailError = document.getElementById("email-error");
    var subjectError = document.getElementById("subject-error");
    var messageError = document.getElementById("message-error");

    if (nameValue === "") {
        nameError.style.display = "block";
    } else {
        nameError.style.display = "none";
    }

    if (emailValue === "") {
        emailError.style.display = "block";
    } else {
        emailError.style.display = "none";
    }

    if (subjectValue === "") {
        subjectError.style.display = "block";
    } else {
        subjectError.style.display = "none";
    }

    if (messageValue === "") {
        messageError.style.display = "block";
    } else {
        messageError.style.display = "none";
    }
}


// Function that will show the preview of the form (activated when user press the Next button)
document.getElementById("btn-next").addEventListener("click", function(event){
    // Prevent form from refresing
    event.preventDefault();
    
    // Check if required fields are empty
    checkFields();

    // If any required field is empty, do not proceed
    if (!document.getElementById("name").checkValidity() ||
        !document.getElementById("email").checkValidity() ||
        !document.getElementById("subject").checkValidity() ||
        !document.getElementById("message").checkValidity()) {
        return;
    }

    // Hide the input fields of the form
    document.getElementById("form-inputs").style.display = "none";
    // Change the text below the "Feedback" title
    document.getElementById("p-instructions").innerHTML = "";
    // Show the preview form
    document.getElementById("form-preview").classList.remove("hidden");
    // Show name
    document.getElementById("name-input").innerHTML = document.getElementById("name").value;
    // Show email
    document.getElementById("email-input").innerHTML = document.getElementById("email").value;
    // Show subject
    document.getElementById("subject-input").innerHTML = document.getElementById("subject").value;
    // Show rating
    let rating = getRadioValue(document.getElementsByName("rating"));
    document.getElementById("rating-input").innerHTML = rating;
    // Show message
    document.getElementById("message-input").innerHTML = document.getElementById("message").value;
});

// Edit form functionality
document.getElementById("edit").addEventListener("click", function(event){
    // Prevent form from refreshing
    event.preventDefault();

    // Show the input fields of the form
    document.getElementById("form-inputs").style.display = "block";

    // Hide the preview of the form
    document.getElementById("form-preview").classList.add("hidden");

    // Populate input fields with previous values
    document.getElementById("name").value = document.getElementById("name-input").textContent;
    document.getElementById("email").value = document.getElementById("email-input").textContent;
    // Since radio buttons cannot be set directly, you need to find the corresponding radio button and check it.
    let rating = document.getElementById("rating-input").textContent;
    let radioButtons = document.getElementsByName("rating");
    for (let i = 0; i < radioButtons.length; i++) {
        if (radioButtons[i].value === rating) {
            radioButtons[i].checked = true;
            break;
        }
    }
    document.getElementById("subject").value = document.getElementById("subject-input").textContent;
    document.getElementById("message").value = document.getElementById("message-input").textContent;
});


// Initialize EmailJS with your User ID
emailjs.init("hzPkb5LEIxer9d0AB");

// Sending information to Email
function sendMail() {
    var formData = {
        name: document.getElementById('name').value,
        email: document.getElementById('email').value,
        rating: document.querySelector('input[name="rating"]:checked').value,
        subject: document.getElementById('subject').value,
        message: document.getElementById('message').value
    }
    emailjs.send("service_rxl2p3w", "template_ayfm12h", formData)
        .then(function(response) {
            alert("Feedback sent successfully!")
        }, function(error) {
            alert('Email sending failed:', error);
            
        });
}

// Attach event listener to form submission
document.getElementById('myForm').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent form submission

    // Send email when form is submitted
    sendMail();
});
