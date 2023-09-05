
function sign_in(event){
    event.preventDefault();
    const passwordField = document.getElementById('password_field');
    const emailField = document.getElementById('email_field');
    const password_prompt = document.getElementById('password_prompt');
    const email_prompt = document.getElementById('email_prompt');
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
        }, 2000); // 3000 毫秒 = 3 秒
    }
    if (emailField.value === '' & passwordField.value === '') {
        console.log('Password is empty');
        email_prompt.style.display = 'block';
        password_prompt.style.display = 'none';
        setTimeout(function() {
            email_prompt.style.display = 'none';
        }, 2000);
    }
}

function sign_up(){
    window.location.href="signUp.html"
}