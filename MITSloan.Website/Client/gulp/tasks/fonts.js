var gulp    = require('gulp');
var util    = require('gulp-util');
var paths   = require('../paths');

module.exports = function () {
    util.log(util.colors.bgBlue.bold('Copying Fonts to output directory'));

    return gulp.src(paths.fonts)
        .pipe(gulp.dest(paths.dist + 'Fonts'));
};