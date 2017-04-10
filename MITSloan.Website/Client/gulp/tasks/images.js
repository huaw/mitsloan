var gulp    = require('gulp');
var util    = require('gulp-util');
var paths   = require('../paths');

module.exports = function () {
    util.log(util.colors.bgBlue.bold('Copying Images to output directory'));

    return gulp.src(paths.images)
        .pipe(gulp.dest(paths.dist + 'Img'));
};