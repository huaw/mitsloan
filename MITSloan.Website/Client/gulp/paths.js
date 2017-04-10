/**
 * Collection of all the locations where to build and get the files
 */

var root = '../../';
var webRoot = root + 'MITSloan.Website/';
var clientRoot = webRoot + 'Client/';
var paths;

module.exports = paths = {
    js: {
        /**
         * Please include vendor, util and global js
         */
        dataVendorBundle: [
            './node_modules/underscore/underscore.js',
            './node_modules/backbone/backbone.js',
            './js/vendor/**/*.js',
            './js/backbone-view-shim.js',
            './js/globals.js'
        ],
        dataCustomJS: [
            '../Areas/**/*.js',
            './js/app.js'
        ]
    },
    scss: {
        dataBundleSCSS: [
            './scss/colors.scss',
            './scss/global.scss',
            './scss/**/*.*',
            '../Areas/**/*.scss'
        ]
    },
    fonts: [
       './fonts/**/*.*'
    ],
    images: [
       './img/**/*.*'
    ],
    dist: webRoot + 'Static/Core/'
};
