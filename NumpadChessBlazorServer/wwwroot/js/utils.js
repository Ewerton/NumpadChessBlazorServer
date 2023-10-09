window.ShowModal = (modalId) => {

    var myModal = new bootstrap.Modal(document.getElementById(modalId));
    myModal.show();
};

window.ScrollToBottom = (elementId) => {

    var element = document.getElementById(elementId);
     element.scrollTop = element.scrollHeight;
};

window.ScrollToTop = (elementId) => {

    var element = document.getElementById(elementId);
    element.scrollTop = 0;
};