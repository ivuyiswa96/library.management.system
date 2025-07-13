
window.modalHelper = {

    showModal: function (modalId) {
        console.log("Trying to show modal: " + modalId);
        const modalEl = document.querySelector(modalId);
        const modal = bootstrap.Modal.getOrCreateInstance(modalEl);
        modal.show();
    },
    hideModal: function (modalId) {
        const modalEl = document.querySelector(modalId);
        const modal = bootstrap.Modal.getInstance(modalEl);
        if (modal) {
            modal.hide();
        }
    }
};
