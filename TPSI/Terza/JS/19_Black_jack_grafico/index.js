"use strict";

window.onload = function () {
    // Riferimenti agli elementi
    let cards = document.getElementsByClassName("card");
    let _btnG = cards[0];
    let _cartaG = cards[1];
    let _btnB = cards[2];
    let _cartaB = cards[3];

    let _puntiG = document.getElementsByTagName("span")[0];
    let _puntiB = document.getElementsByTagName("span")[1];
    let _assoG = document.getElementsByClassName("msgAsso")[0];
    let _assoB = document.getElementsByClassName("msgAsso")[1];

    let _chkG = _assoG.children[0];
    let _chkB = _assoB.children[0];

    // Inizializzazione
    _assoG.style.visibility = "hidden";
    _assoB.style.visibility = "hidden";
    _btnG.style.opacity = 0.5;
    _btnB.style.opacity = 0.5;

    // Effetti hover
    _btnG.addEventListener("mouseover", function () {
        _btnG.style.opacity = 1;
    });
    _btnG.addEventListener("mouseout", function () {
        _btnG.style.opacity = 0.5;
    });

    _btnB.addEventListener("mouseover", function () {
        _btnB.style.opacity = 1;
    });
    _btnB.addEventListener("mouseout", function () {
        _btnB.style.opacity = 0.5;
    });

    // Click dei bottoni
    _btnG.addEventListener("click", function () {
        pescaCarta(_cartaG);
    });
    _btnB.addEventListener("click", function () {
        pescaCarta(_cartaB);
    });

    // Funzione pesca carta
    function pescaCarta(carta) {
        let numero = generaNumero(1, 14);
        let seme = String.fromCharCode(generaNumero(97, 100)); // 'a' - 'd'
        let file = numero + seme;
        carta.style.backgroundImage = "url('img/" + file + ".gif')";
    }

    // Funzione generazione numero
    function generaNumero(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
};
