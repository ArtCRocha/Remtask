// Menu

var btnMenu = document.getElementById("btn-menu");

const toggleMenu = () => {
    var containerMenu = document.querySelector(".container-itens-menu");
    containerMenu.classList.toggle("active");
}

btnMenu.addEventListener("click", toggleMenu);
