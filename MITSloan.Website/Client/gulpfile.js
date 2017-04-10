var gulp = require('./gulp')([
    'script-bundle',
    'scss',
    'fonts',
    'jshint',
    'watch',
    'images'
]);

gulp.task('build', ['jshint', 'script-bundle', 'scss', 'fonts', 'images']);
gulp.task('default', ['build', 'watch']);