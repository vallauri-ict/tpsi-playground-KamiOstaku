"use strict"
const DIM = 4;
const wrapper = document.getElementById("wrapper");
let aus = [];

for (let i = 0; i < DIM; i++) {
    for (let j = 0; j < DIM; j++) {
        const div = document.createElement("div");
        wrapper.appendChild(div);
        div.classList.add("pedina");
        let n
        do {
            n = generaNumero(1, 17);
        } while (aus.includes(n))
        aus.push(n);
        if (n <= 15) 
        {
            div.style.backgroundColor = "blue";
            div.textContent = n;
        }
        div.id = `div-${i}-${j}`;
        
        div.addEventListener("click", function()
        {
            let i = parseInt(this.id.split("-")[1]);
            let j = parseInt(this.id.split("-")[2]);

        });

    }
}

function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}