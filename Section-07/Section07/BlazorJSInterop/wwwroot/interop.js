"use strict";

window.blazorInterop = {
    registerOnScrollListener: function (element) {
        element.addEventListener("scroll", function (event) {
            if (event.target) {
                if (event.target.scrollHeight - event.target.offsetHeight - event.target.scrollTop < 1) {
                    DotNet.invokeMethodAsync('BlazorJSInterop', 'TriggerNextLoad');
                }
            }
        });
    }
}