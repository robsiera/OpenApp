﻿$(function () {

    ELEMENT.locale(ELEMENT.lang.fr);

    new Vue({
        el: '#app',
        template: "#appTemplate",
        data: {
            message: abp.localization.values.Starter.WellcomeMessage
        }
    })
});
