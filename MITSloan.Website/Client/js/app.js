/**
 * @Filename: app.js, used for initilize project modules
 * @Author: 
 */

(function ($, mitsloan) {
    'use strict';

    /**
     * Loader
     * @returns {{init: Function}}
     * @constructor
     */

    var Loader = function () {
        var components = null;
        var view = '';
        var model = '';
        var collection = '';
        var viewsInstances = [];
        var tempCollection = null;

        /**
         * Initializer
         */
        var init = function () {

            components = $('[data-view]');

            _.each(components, function (component) {
                view = $(component).attr('data-view');
                model = $(component).attr('data-model');
                collection = $(component).attr('data-collection');

                if (mitsloan.views[view] !== undefined) {

                    if (collection === undefined) {
                        viewsInstances.push(new mitsloan.views[view]({
                            el: $(component),
                            model: mitsloan.models[model] !== undefined ? new mitsloan.models[model]() : null
                        }));
                    } else {
                        tempCollection = _.find(mitsloan.dataLoader.collections, (dataLoaderCollection) => {
                            return dataLoaderCollection.name === collection;
                        });

                        if (!tempCollection) {
                            console.error('Probably caused by not found collection with name ' + collection +
                                ' please check that the name matches an actual package. Available packages:', mitsloan.dataLoader.collections);
                        }

                        viewsInstances.push(new mitsloan.views[view]({
                            el: $(component),
                            collection: tempCollection.object
                        }));
                    }

                } else {
                    throw new Error('No view found for ' + view);
                }

            });
        };

        // Public
        return {
            init: init,
            viewInstances: viewsInstances
        };
    };

    // Starting the application
    window.loader = new Loader();
    window.loader.init();

})(jQuery, mitsloan);
