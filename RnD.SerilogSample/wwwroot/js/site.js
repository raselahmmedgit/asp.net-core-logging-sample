var AppBootstrapDatepicker = function () {

    var _init = function () {

        $(".datepicker-control").datepicker({
            autoclose: true,
            todayHighlight: true,
            //format: 'dd/MM/yyyy' //26/May/2023
            format: 'dd/mm/yyyy' //26/05/2023
        });

        $('.datepicker-modal-control').datepicker('destroy');
        $(".datepicker-modal-control").datepicker({
            autoclose: true,
            todayHighlight: true,
            //format: 'dd/MM/yyyy', //26/May/2023
            format: 'dd/mm/yyyy', //26/05/2023
            container: '.modal-body'
        });

        //$(".datepicker-control").datepicker({
        //    autoclose: true,
        //    todayHighlight: true,
        //    //format: 'dd/MM/yyyy' //26/May/2023
        //    format: 'dd/mm/yyyy' //26/05/2023
        //});

    };

    return {
        Init: _init
    };
}();
