"use strict"
const ROSSO = "rgb(255, 0, 0)"
const GIALLO = "rgb(255, 255, 0)"
const VERDE = "rgb(0, 220, 0)"
const BLU = "rgb(0, 0, 220)"
const CIANO = "rgb(0, 255, 255)"
const VIOLA = "rgb(135, 38, 165)"

const GRIGIO = "rgb(235, 235, 235)"
const NERO = "rgb(0, 0, 0)"
const GRIGIO_SCURO = "rgb(110, 110, 110)"

let numSegreti = new Array(4)
let numUtente = new Array(4)
let rigaCorrente = 0

for (let i = 0; i < numSegreti.length; i++) {
    numSegreti[i] = generaNumero(1, 6)
}

function creaRiga() {
    let table = document.querySelector("table")
    let tr = document.createElement("tr")

    let tdNumero = document.createElement("td")
    tdNumero.textContent = rigaCorrente + 1
    tr.appendChild(tdNumero)

    let tdColori = document.createElement("td")
    for (let i = 0; i < 4; i++) {
        let div = document.createElement("div")
        div.id = `div-${rigaCorrente}-${i}`
        div.classList.add("pedina")
        div.style.backgroundColor = ROSSO
        div.addEventListener("click", function () {
            cambiaColore(div, i)
        })
        tdColori.appendChild(div)
    }

    let button = document.createElement("button")
    button.textContent = "Invia"
    button.addEventListener("click", function () {
        verificaTentativo()
    })
    tdColori.appendChild(button)
    tr.appendChild(tdColori)

    let tdRisultato = document.createElement("td")
    for (let i = 0; i < 4; i++) {
        let div = document.createElement("div")
        div.id = `ris-${rigaCorrente}-${i}`
        div.classList.add("pedina")
        div.style.backgroundColor = GRIGIO
        tdRisultato.appendChild(div)
    }
    tr.appendChild(tdRisultato)

    table.appendChild(tr)
}

function verificaTentativo() {
    let esatti = 0
    let presenti = 0

    for (let i = 0; i < 4; i++) {
        if (numUtente[i] === numSegreti[i]) {
            esatti++
            numSegreti[i] = null
            numUtente[i] = null
        }
    }

    for (let i = 0; i < 4; i++) {
        if (numUtente[i] !== null) {
            let indice = numSegreti.indexOf(numUtente[i])
            if (indice !== -1) {
                presenti++
                numSegreti[indice] = null
            }
        }
    }

    for (let i = 0; i < esatti; i++) {
        document.getElementById(`ris-${rigaCorrente}-${i}`).style.backgroundColor = NERO
    }
    for (let i = esatti; i < esatti + presenti; i++) {
        document.getElementById(`ris-${rigaCorrente}-${i}`).style.backgroundColor = GRIGIO_SCURO
    }

    if (esatti === 4) {
        alert("Hai vinto!")
        return
    }

    rigaCorrente++
    creaRiga()
}

function cambiaColore(div, index) {
    const colori = [ROSSO, GIALLO, VERDE, BLU, CIANO, VIOLA]
    let coloreCorrente = div.style.backgroundColor
    let nuovoColore = colori[0]

    if (coloreCorrente) {
        let indiceCorrente = colori.indexOf(coloreCorrente)
        nuovoColore = colori[(indiceCorrente + 1) % colori.length]
    }

    div.style.backgroundColor = nuovoColore
    numUtente[index] = colori.indexOf(nuovoColore) + 1
}

function assegnaColore(n) {
    let colore = ""
    switch (n) {
        case 1: colore = ROSSO; break
        case 2: colore = GIALLO; break
        case 3: colore = VERDE; break
        case 4: colore = BLU; break
        case 5: colore = CIANO; break
        case 6: colore = VIOLA; break
    }
    return colore
}

function generaNumero(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min
}

creaRiga()


