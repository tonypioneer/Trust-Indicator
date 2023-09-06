document.addEventListener("DOMContentLoaded", function() {
    const accordionSelects = document.querySelectorAll('.accordion-select');
    let currentlyOpen;

    accordionSelects.forEach((select) => {
        select.addEventListener('change', function() {
            if (this.checked) {
                if (currentlyOpen) {
                    currentlyOpen.checked = false;
                }
                resetChangePasswordForm()
                currentlyOpen = this;
            } else {
                if (currentlyOpen === this) {
                    currentlyOpen = null;
                }

            }
        });
    });
});
function resetChangePasswordForm() {
    const new_password = document.getElementById('new-password');
    const confirm_password = document.getElementById('confirm-new-password');
    const old_password = document.getElementById('old-password');
    const email = document.getElementById('email');
    const show_password = document.getElementById('show-password');
    const prompt_box = document.querySelector('.wrong-prompt');
    const passwordField = document.getElementById("new-password");

    new_password.value = '';
    confirm_password.value = '';
    old_password.value = '';
    email.value = '';
    show_password.checked = false;
    prompt_box.style.display = 'none';
    passwordField.type='password'
}
function togglePasswordVisibility() {
    const passwordField = document.getElementById("new-password");
    if (passwordField.type === "password") {
        passwordField.type = "text";
    } else {
        passwordField.type = "password";
    }
}

function change_password(){
    const new_password=document.getElementById('new-password').value;
    const confirm_password=document.getElementById('confirm-new-password').value
    const prompt_text= document.querySelector('.wrong-prompt p');
    const prompt_box= document.querySelector('.wrong-prompt');
    if (new_password!==confirm_password){
        prompt_box.style.display='block'
        prompt_text.textContent='Please re-check the password you entered. The new password does not match the Re-enter password.'
    }
}