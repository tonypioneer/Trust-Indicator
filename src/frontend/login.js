
function sign_in(event){
    event.preventDefault();
    const passwordField = document.getElementById('password_field');
    const emailField = document.getElementById('email_field');
    const password_prompt = document.getElementById('password_prompt');
    const email_prompt = document.getElementById('email_prompt');
    const wrong_prompt = document.querySelector('.wrong-prompt');
    const email = emailField.value;
    const password = passwordField.value;
    if (passwordField.value === '') {
        console.log('Password is empty');
        password_prompt.style.display = 'block';
        setTimeout(function() {
            password_prompt.style.display = 'none';
        }, 2000);
    }
    if (emailField.value === '') {
        console.log('Password is empty');
        email_prompt.style.display = 'block';
        setTimeout(function() {
            email_prompt.style.display = 'none';
        }, 2000);
    }
    if (emailField.value === '' & passwordField.value === '') {
        console.log('Password is empty');
        email_prompt.style.display = 'block';
        password_prompt.style.display = 'none';
        setTimeout(function() {
            email_prompt.style.display = 'none';
        }, 2000);
    }
    fetch(`https://localhost:5000/user/login?email=${email}&password=${password}`, {
        method: "POST",
    })
        .then(response => response.json())
        .then(data => {
            if (data) {
                sessionStorage.setItem('userEmail', email);
                window.location.href="index.html";
            } else {
                wrong_prompt.style.display="block";
            }
        })
        .catch(error => {
            wrong_prompt.style.display="block";
        });
}
function sign_up(){
    window.location.href="signup.html"
}
function access(){
    window.location.href="changepassword.html"
}