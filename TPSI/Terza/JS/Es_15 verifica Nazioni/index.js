"use strict"

const div1Text = div1.querySelectorAll("input[type=text]");
const div1Radio = div1.querySelectorAll("input[type=radio]");
const div2Text = div2.querySelectorAll("input[type=text]");
const div2Radio = div2.querySelectorAll("input[type=radio]");

let aux = new Array(div1Text.length);

for (let i = 0; i < div1Text.length; i++) {
    div1Text[i].readOnly = true;
    aux[i] = div1Text[i].value;
}
for (let i = 0; i < div2Text.length; i++) {
    div2Text[i].readOnly = true;
}

for (let i = 0; i < div1Radio.length; i++) {
    div1Radio[i].disabled = true;
}

let intAux = 0;

for (let i = 0; i < div2Text.length; i += 2) {
    let x = random(intAux, aux.length)
    div2Text[i].value = aux[x];

    let aux3 = aux[intAux];
    aux[intAux] = aux[x];
    aux[x] = aux3;
    intAux++;
}

let select = 0;

function seleziona()
{
    do
    {
        select = random(0,div1Radio.length);
    }while(div1Text[select].disabled === true || div1Text[select].value === "");
    div1Radio[select].checked = true;
}

function random(a, b) {
    return Math.floor((b - a) * Math.random()) + a;
}
