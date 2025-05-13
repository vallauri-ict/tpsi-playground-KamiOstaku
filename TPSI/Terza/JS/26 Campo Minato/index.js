"use strict"


const wrapper = document.getElementById("wrapper");
let nBombe = 0;
let nClick = 0;
let bottoni = Array.from(Array(5), () => Array(5));
for (let i = 0; i < 5; i++) {
    for (let j = 0; j < 5; j++) {
        let btn = document.createElement("button");
        wrapper.appendChild(btn);
        btn.bomba = false;

        btn.addEventListener("click", function () {
            if (this.bomba) {
                alert("Hai Perso");
                disabilitaBottoni();
            }
            else {
                this.style.backgroundColor = "white";
                this.textContent = contaBombeAttorno(i, j);
                if (this.textContent > "0") {
                    this.style.color = "red";
                }
                this.disabled = true;
            }
            nClick++;

            if (nClick == 20) {
                alert("Hai vinto");
                disabilitaBottoni();
            }
        });


        bottoni[i][j] = btn;
    }

    if (i >= 4) {
        creaBomba();
    }
}

function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}

function creaBomba() {
    let x, y;
    do {
        x = generaNumero(0, 5);
        y = generaNumero(0, 5);
        if (bottoni[x][y].bomba == false) {
            bottoni[x][y].bomba = true;
            nBombe++;
        }
    } while (nBombe < 5);
}

function disabilitaBottoni() {
    for (let i = 0; i < 5; i++) {
        for (let j = 0; j < 5; j++) {
            bottoni[i][j].disabled = true;
        }
    }
}

function contaBombeAttorno(x, y) {
    let cont = 0;

    for (let i = y - 1; i < y + 2; i++)
    {
        if (i >= 0 && i < 5)
        {
            for (let j = x - 1; j < x + 2; j++)
            {
                if (j >= 0 && j < 5) 
                {
                    if (bottoni[j][i].bomba) 
                    {
                        cont++;
                    }
                }
            }
        }
    }
    return cont;
}