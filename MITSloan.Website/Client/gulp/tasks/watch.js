var gulp        = require('gulp');
var util        = require('gulp-util');
var $           = require('gulp-load-plugins')();
var paths       = require('../paths');


module.exports = function () {
    util.log(util.colors.bgGreen.bold('Gulp is now watching for changes!'));

    gulp.watch(paths.scss.dataBundleSCSS , ['scss']);
    gulp.watch(paths.js.dataCustomJS, ['jshint', 'script-bundle']);
    gulp.watch(paths.js.dataVendorBundle, ['jshint', 'script-bundle']);
    gulp.watch(paths.images, ['images']);
};