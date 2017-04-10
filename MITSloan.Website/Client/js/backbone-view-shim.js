Backbone.View.prototype.remove = function () {
    'use strict';

    this.undelegateEvents();
    this.$el.empty();
    this.stopListening();
    return this;
};

/**
 * Close view to prevent zombies on backbone
 * This method should be called when view is no longer displayed
 */
Backbone.View.prototype.close = function () {
    'use strict';

    /**
     * Unbind any event attached by this view
     */
    this.unbind();

    /**
     * When onClose exist, execute it
     * The purpose of this code is to enable a custom on close method
     */
    if (this.onClose) {
        this.onClose();
    }

    return this;
};
