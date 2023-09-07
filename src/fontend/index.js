function top_register(){
    window.location.href="signup.html"
}

document.addEventListener('click', function(event) {
    const signInDiv = document.querySelector('.login-container');
    const signInContent = document.querySelector('.sign-in-content');
    const languageChangeDiv = document.querySelector('.language-change');
    const languageOptions = document.getElementById('language-options');

    if (signInContent.style.display === 'block' &&
        !signInDiv.contains(event.target) &&
        !signInContent.contains(event.target)) {
        signInContent.style.display = 'none';
    }

    if (!languageChangeDiv.contains(event.target)) {
        languageOptions.classList.add('hidden');
    }
});

function sign_in(event) {
    event.stopPropagation();  // 阻止事件冒泡

    const signInContent = document.querySelector('.sign-in-content');
    if(signInContent.style.display === 'block') {
        signInContent.style.display = 'none';  // 如果已经显示则隐藏
    } else {
        signInContent.style.display = 'block';  // 如果隐藏则显示
    }

    const dropdown = document.getElementById('language-options');
    dropdown.classList.add('hidden');
}

function toggleDropdown(event) {
    event.stopPropagation();  // 阻止事件冒泡

    const dropdown = document.getElementById('language-options');
    const signInContent = document.querySelector('.sign-in-content');
    if(dropdown.classList.contains('hidden')) {
        dropdown.classList.remove('hidden');
        signInContent.style.display = 'none';  // 隐藏登录内容
    } else {
        dropdown.classList.add('hidden');
    }
}
function updateLanguage(code, event) {
    const selectedLanguage = document.getElementById('selected-language');
    selectedLanguage.textContent = code;
    const dropdown = document.getElementById('language-options');
    dropdown.classList.add('hidden');

    // 阻止事件冒泡，避免触发.language-change的onclick事件
    event.stopPropagation();
}