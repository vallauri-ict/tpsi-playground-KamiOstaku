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

    let wrapper = document.getElementById("wrapper");
    let addPlayerButton = document.getElementById("addPlayer");
    let playerNameInput = document.getElementById("playerName");

    let players = []; // Array per tenere traccia dei giocatori
    let carteUscite = []; // Carte già pescate

    // Punteggi
    let punteggioG = 0;
    let punteggioB = 0;

    // Inizializzazione
    inizializzaGioco();

    addPlayerButton.addEventListener("click", function () {
        let playerName = playerNameInput.value.trim();
        if (playerName === "") {
            alert("Inserisci un nome valido!");
            return;
        }

        // Crea un nuovo giocatore
        let player = {
            name: playerName,
            score: 0,
            element: createPlayerElement(playerName),
        };
        players.push(player);

        // Aggiungi il giocatore al wrapper
        wrapper.appendChild(player.element);

        // Resetta il campo di input
        playerNameInput.value = "";
    });

    function inizializzaGioco() {
        // Nascondi checkbox assi
        _assoG.style.visibility = "hidden";
        _assoB.style.visibility = "hidden";
        
        // Imposta opacità iniziale e dorsi delle carte
        _btnG.style.opacity = 0.5;
        _btnB.style.opacity = 0.5;
        _btnG.style.backgroundImage = "url('img/dorso.gif')";
        _btnB.style.backgroundImage = "url('img/dorso.gif')";
        _cartaG.style.backgroundImage = "none";
        _cartaB.style.backgroundImage = "none";

        // Eventi hover
        _btnG.addEventListener("mouseover", () => _btnG.style.opacity = 1);
        _btnG.addEventListener("mouseout", () => _btnG.style.opacity = 0.5);
        _btnB.addEventListener("mouseover", () => _btnB.style.opacity = 1);
        _btnB.addEventListener("mouseout", () => _btnB.style.opacity = 0.5);

        // Eventi click
        _btnG.addEventListener("click", giocatoreGioca);
        _btnB.addEventListener("click", bancoGioca);
    }

    function createPlayerElement(name) {
        // Crea il contenitore del giocatore
        let playerDiv = document.createElement("div");
        playerDiv.className = "col-md-5 text-center";

        // Nome e punteggio
        playerDiv.innerHTML = `
            <p class="fs-4">${name}: <span>0</span></p>
            <div class="d-flex justify-content-center">
                <div class="card"></div>
                <div class="card"></div>
            </div>
            <div class="msgAsso mt-3">
                <input type="checkbox" autocomplete="off"> Assegna 11 punti all'asso
            </div>
        `;

        // Eventi per le carte
        let cards = playerDiv.querySelectorAll(".card");
        let scoreSpan = playerDiv.querySelector("span");
        let assoCheckbox = playerDiv.querySelector("input[type='checkbox']");

        cards.forEach((card, index) => {
            card.addEventListener("click", function () {
                let carta = generaCarta();
                mostraCarta(card, carta);

                let valore = parseInt(carta.substr(1));
                if (valore > 10) valore = 10;

                if (valore === 1) {
                    assoCheckbox.style.visibility = "visible";
                    assoCheckbox.onchange = function () {
                        if (this.checked) {
                            player.score += 10;
                            scoreSpan.textContent = player.score;
                            assoCheckbox.style.visibility = "hidden";
                        }
                    };
                }

                player.score += valore;
                scoreSpan.textContent = player.score;

                if (player.score > 21) {
                    alert(`${name} ha perso!`);
                    disablePlayer(playerDiv);
                }
            });
        });

        return playerDiv;
    }

    function generaCarta() {
        let carta;
        do {
            let numero = Math.floor(Math.random() * 13) + 1;
            let seme = String.fromCharCode(Math.floor(Math.random() * 4) + 97); // a-d
            carta = seme + numero;
        } while (carteUscite.includes(carta));

        carteUscite.push(carta);
        return carta;
    }

    function mostraCarta(elemento, carta) {
        elemento.style.transition = "transform 0.5s";
        elemento.style.transform = "rotateY(90deg)";
        setTimeout(() => {
            elemento.style.backgroundImage = `url('img/${carta}.gif')`;
            elemento.style.transform = "rotateY(0deg)";
        }, 250);
    }

    function giocatoreGioca() {
        // Nascondi checkbox asso se visibile
        _assoG.style.visibility = "hidden";
        _chkG.checked = false;
        
        let carta = generaCarta();
        mostraCarta(_cartaG, carta);
        
        let valore = parseInt(carta.substr(1));
        if (valore > 10) valore = 10;
        
        if (valore === 1) {
            _assoG.style.visibility = "visible";
            _chkG.onchange = function() {
                if (this.checked) {
                    punteggioG += 10;
                    _puntiG.textContent = punteggioG;
                    _assoG.style.visibility = "hidden";
                }
            };
        }
        
        punteggioG += valore;
        _puntiG.textContent = punteggioG;
        
        if (punteggioG > 21) {
            alert("Il giocatore perde!");
            rimuoviEventi();
        }
    }

    function bancoGioca() {
        // Rimuovi eventi del giocatore
        _btnG.removeEventListener("click", giocatoreGioca);
        
        // Nascondi checkbox asso se visibile
        _assoB.style.visibility = "hidden";
        _chkB.checked = false;
        
        let carta = generaCarta();
        mostraCarta(_cartaB, carta);
        
        let valore = parseInt(carta.substr(1));
        if (valore > 10) valore = 10;
        
        if (valore === 1 && (punteggioB + 11) <= 21) {
            punteggioB += 10;
        }
        
        punteggioB += valore;
        _puntiB.textContent = punteggioB;
        
        if (punteggioB > 21) {
            alert("Il giocatore vince!");
            rimuoviEventi();
        } else if (punteggioB > punteggioG) {
            alert("Vince il banco!");
            rimuoviEventi();
        } else if (punteggioB === punteggioG) {
            alert("Parità!");
            rimuoviEventi();
        }
    }

    function disablePlayer(playerDiv) {
        let cards = playerDiv.querySelectorAll(".card");
        cards.forEach((card) => {
            card.style.pointerEvents = "none";
        });
    }

    function rimuoviEventi() {
        _btnG.removeEventListener("click", giocatoreGioca);
        _btnB.removeEventListener("click", bancoGioca);
        let rimuoviHover = (btn) => {
            btn.removeEventListener("mouseover", () => btn.style.opacity = 1);
            btn.removeEventListener("mouseout", () => btn.style.opacity = 0.5);
        };
        rimuoviHover(_btnG);
        rimuoviHover(_btnB);
    }
};
