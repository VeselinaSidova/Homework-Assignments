window.addEventListener('load', solve);

function solve() {
    const productTypeElement = document.getElementById('type-product');
    const descriptionElement = document.getElementById('description');
    const clientNameElement = document.getElementById('client-name');
    const clientPhoneElement = document.getElementById('client-phone');
    const submitButtonELement = document.querySelector('form button');
    const receivedOrdersSectionElement = document.getElementById('received-orders');
    const finishedOrdersSectionElement = document.getElementById('completed-orders');
    const clearButtonElement = finishedOrdersSectionElement.querySelector('button');

    submitButtonELement.addEventListener('click', sendForm);

    function sendForm(event) {
        event.preventDefault();
        if (productTypeElement.value == 'Computer' || productTypeElement.value == 'Phone') {
            if (descriptionElement.value != '' && clientNameElement.value != '' && clientPhoneElement.value != '') {
                const divElement = document.createElement('div');
                divElement.classList.add('container');
    
                divElement.innerHTML = `<h2>Product type for repair: ${productTypeElement.value}</h2>
                                        <h3>Client information: ${clientNameElement.value}, ${clientPhoneElement.value}</h3>
                                        <h4>Description of the problem: ${descriptionElement.value}</h4>
                                        <button class="start-btn">Start repair</button>
                                        <button class="finish-btn" disabled>Finish repair</button>`;
    
                const divButtonElements = divElement.querySelectorAll('button');
    
                divButtonElements[0].addEventListener('click', startRepair);
                divButtonElements[1].addEventListener('click', finishRepair);
                clearButtonElement.addEventListener('click', clearOrders);
    
                receivedOrdersSectionElement.appendChild(divElement);
            }
        }

        descriptionElement.value = '';
        clientNameElement.value = '';
        clientPhoneElement.value = '';
        productTypeElement.value = '';
    }

    function startRepair(e) {
        e.preventDefault();
        e.target.disabled = true;
        e.target.nextElementSibling.disabled = false; 
    }

    function finishRepair(e) {
        e.preventDefault();

        const divElement = receivedOrdersSectionElement.querySelector('div');
        const buttonElements = divElement.querySelectorAll('button');

        divElement.removeChild(buttonElements[0]);
        divElement.removeChild(buttonElements[1]);

        finishedOrdersSectionElement.appendChild(divElement);
    }

    function clearOrders(e) {
        e.preventDefault();
        const divElements = e.target.parentElement.querySelectorAll('div');

        for (const divElement of divElements) {
            e.target.parentElement.removeChild(divElement);
        }
    }
}