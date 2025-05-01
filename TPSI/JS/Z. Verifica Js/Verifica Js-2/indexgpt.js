"use strict";

const _lstVoci = document.getElementById("lstVoci");
const _txtNum = document.getElementsByClassName("txtNum");
const _txtStr = document.getElementsByClassName("txtStr");
const _chk = document.querySelectorAll("#chkRis input[type=checkbox]");
const _btnControlla = document.getElementById("btnControlla");

let asciiValues = [];

_lstVoci.selectedIndex = -1;

function generaNumero(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function genera() {
    let [min, max] = _lstVoci.value.split("-").map(Number);
    let numeri = new Set();

    while (numeri.size < 6) {
        numeri.add(generaNumero(min, max));
    }

    asciiValues = Array.from(numeri);

    for (let i = 0; i < _txtNum.length; i++) {
        _txtNum[i].value = asciiValues[i];
        _txtStr[i].value = "";
        _txtStr[i].disabled = false;
        _chk[i].checked = false;
    }

    _btnControlla.disabled = true;
}

function abilita() {
    let tuttiCompilati = Array.from(_txtStr).every(txt => txt.value.length === 1);
    _btnControlla.disabled = !tuttiCompilati;
}

function controlla() {
    let corretti = 0;

    for (let i = 0; i < asciiValues.length; i++) {
        let userChar = _txtStr[i].value;
        let correctChar = String.fromCharCode(asciiValues[i]);

        if (userChar === correctChar) {
            _txtStr[i].disabled = true;
            _chk[i].checked = true;
            corretti++;
        } else {
            _chk[i].checked = false;
        }
    }

    if (corretti === 6) {
        alert("Complimenti! Tutte le risposte sono corrette.");
    } else {
        alert("Alcune risposte sono errate. Riprova.");
    }
}
