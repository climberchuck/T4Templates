
ko.extenders.validate = function (target, options) {
    target.hasError = ko.observable();
    target.validationMessage = ko.observable();

    function validate(newValue) {
        if (options.required) {
            target.hasError(newValue ? false : true);
            target.validationMessage(options.required);

        }
    }
    validate(target());
    target.subscribe(validate);
    return target;
};
/* Example usage
ko.observable().extend({ validate: {required:"errormessage"}});

*/