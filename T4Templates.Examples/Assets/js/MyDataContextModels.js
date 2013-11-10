


(function () {
    var nameSpace = 'MyNameSpaceHere';
    var ns = {};
    ns.Models = {
        Person: function (data) {
            this.PersonKey = ko.observable();

            this.FirstName = ko.observable();

            this.LastName = ko.observable();

            this.update = function (data) {
                ko.mapping.fromJS(data, {}, this);
            }
            if (data != undefined) {
                this.update(data);
            }
        },

        Project: function (data) {
            this.ProjectKey = ko.observable();

            this.Name = ko.observable();

            this.Vendors = ko.observableArray();
            this.update = function (data) {
                ko.mapping.fromJS(data, {}, this);
            }
            if (data != undefined) {
                this.update(data);
            }
        },

        Vendor: function (data) {
            this.VendorKey = ko.observable();

            this.Name = ko.observable();

            this.update = function (data) {
                ko.mapping.fromJS(data, {}, this);
            }
            if (data != undefined) {
                this.update(data);
            }
        },

    }
    window[nameSpace] = ns || {};
})();
