var gulp        = require('gulp');
var util        = require('gulp-util');
var $           = require('gulp-load-plugins')();
var uglify      = require('gulp-uglify');
var paths       = require('../paths');
var babel       = require('gulp-babel');
var es2015      = require('babel-preset-es2015');


function onError(err) {
    util.log(util.colors.red(err.message));
}

module.exports = function () {
    util.log(util.colors.bgBlue.bold('Compiling ---> JS ---> Script Bundle'));
    var source = paths.js.dataVendorBundle.concat(paths.js.dataCustomJS);
    return gulp.src(source)
        .pipe($.sourcemaps.init())
        .pipe(babel({
            presets: [es2015],
            ignore: paths.js.dataVendorBundle
        }))
        .pipe($.concat('mitsloan.min.js'))
        .pipe(uglify({ preserveComments: 'license' },{
            compress:
                {
                    drop_debugger: false
                }
        } ))
        .pipe($.sourcemaps.write('.'))
        .pipe(gulp.dest(paths.dist + 'Js'));
};