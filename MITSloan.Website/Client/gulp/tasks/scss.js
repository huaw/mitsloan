var gulp        = require('gulp');
var util        = require('gulp-util');
var $           = require('gulp-load-plugins')();
var paths       = require('../paths');


function onError(err) {
    util.log(util.colors.red(err.message));
}

module.exports = function () {
    util.log(util.colors.bgBlue.bold('Compiling ---> SCSS ---> CSS'));
    return gulp.src(paths.scss.dataBundleSCSS)
        .pipe($.sourcemaps.init())
        .pipe($.concat('app.min.css'))
        .pipe($.sass({ preserveComments: 'license' }))
        .pipe($.minifyCss())
        .pipe($.sourcemaps.write('.'))
        .pipe(gulp.dest(paths.dist + 'Css'));
};