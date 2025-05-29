"use strict"

const row = 5;
const col = 5;
const BOMBS = 5;
const MAX_CLICKS = 20;

let clickCount = 0;
const wrapper = document.getElementById("wrapper");

createBoard();
placeBombs();

function createBoard() {
    for(let i = 0; i < row; i++) {
        for(let j = 0; j < col; j++) {
            const btn = document.createElement("button");
            btn.classList.add("button");
            btn.id = `${i}-${j}`;
            btn.setAttribute("bomba", "false");
            btn.addEventListener("click", buttonPressed);
            wrapper.appendChild(btn);
        }
    }
}


function placeBombs() {
    let bombsPlaced = 0;
    while(bombsPlaced < BOMBS) {
        const i = generaNumero(0, row-1);
        const j = generaNumero(0, col-1);
        const btn = document.getElementById(`${i}-${j}`);
        if(btn.getAttribute("bomba") === "false") {
            btn.setAttribute("bomba", "true");
            bombsPlaced++;
        }
    }
}

function buttonPressed() {
    const btn = this;
    const i = parseInt(btn.id.split("-")[0]);
    const j = parseInt(btn.id.split("-")[0]);
    
    if(btn.getAttribute("bomba") === "true") {
        const img = document.createElement("img");
        img.src = "bomb.png";
        img.style.width = "30px";
        img.style.height = "30px";
        btn.innerHTML = "";
        btn.appendChild(img);
        alert("Hai perso!");
        disableAllButtons();
        return;
    }

    clickCount++;
    btn.style.backgroundColor = "white";
    btn.disabled = true;

    const bombCount = checkAdjacentBombs(i, j);
    if(bombCount > 0) {
        btn.innerHTML = bombCount;
    }

    if(clickCount === MAX_CLICKS) {
        alert("Hai vinto! Hai evitato tutte le bombe!");
        disableAllButtons();
    }
}

function checkAdjacentBombs(i, j) {
    let count = 0;
    // Controllo casella sopra
    if(i > 0) {
        const btn = document.getElementById(`${i-1}-${j}`);
        if(btn.getAttribute("bomba") === "true") count++;
    }
    // Controllo casella sotto
    if(i < row-1) {
        const btn = document.getElementById(`${i+1}-${j}`);
        if(btn.getAttribute("bomba") === "true") count++;
    }
    // Controllo casella sinistra
    if(j > 0) {
        const btn = document.getElementById(`${i}-${j-1}`);
        if(btn.getAttribute("bomba") === "true") count++;
    }
    // Controllo casella destra
    if(j < col-1) {
        const btn = document.getElementById(`${i}-${j+1}`);
        if(btn.getAttribute("bomba") === "true") count++;
    }
    return count;
}

function disableAllButtons() {
    const buttons = document.getElementsByTagName("button");
    for(let btn of buttons) {
        btn.removeEventListener("click", buttonPressed);
        if(btn.getAttribute("bomba") === "true") {
            const img = document.createElement("img");
            img.src = "bomb.png";
            img.style.width = "30px";
            img.style.height = "30px";
            btn.innerHTML = "";
            btn.appendChild(img);
        }
    }
}


function generaNumero(min, max) {
    return Math.floor((max-min) * Math.random()) + min;
}