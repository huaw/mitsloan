var gulp        = require('gulp');
var util        = require('gulp-util');
var paths       = require('../paths');
var jshint      = require('gulp-jshint');
var $           = require('gulp-load-plugins')();

module.exports = function () {
    util.log(util.colors.bgGreen.bold('JSHint'));

    return gulp.src(paths.js.dataCustomJS)
        .pipe(jshint('.jshintrc'))
        .pipe(jshint.reporter('jshint-stylish'))
        .pipe(jshint.reporter('fail'));
};