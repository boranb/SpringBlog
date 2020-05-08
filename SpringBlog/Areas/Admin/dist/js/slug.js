function slugFunc() {

    this.ajaxUrl = null;

    this.init = function (ajaxUrl) {
        this.ajaxUrl = ajaxUrl;
    };

    this.run = function (sourceSelector, targetSelector, refreshSelector) {

        var _ajaxUrl = this.ajaxUrl;

        function generateSlug() {
            console.log(_ajaxUrl);
            var title = $(sourceSelector).val();
            if (!title) return;

            $.post(_ajaxUrl, { title: title }, function (data) {
                $(targetSelector).val(data);
                $(targetSelector).trigger("blur"); // validation'ı tetiklemek için // in order to trigger - validation blur
            });
        }

        $(sourceSelector).change(function () {
            if (!$(targetSelector).val()) {
                generateSlug();
            }
        });

        $(refreshSelector).click(function (event) {
            event.preventDefault();
            generateSlug();
        });

    };
}

var slug = new slugFunc();