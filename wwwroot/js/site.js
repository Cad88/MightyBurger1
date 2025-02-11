// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.querySelector('.navbar-toggle').addEventListener('click', () => {
    document.querySelector('.navbar-links').classList.toggle('active');
});