<?php

namespace Core\View;

class View
{

    /**
     * The array that holds the assigned data for the view.
     *
     * @var array
     */
    private $data = [];

    /**
     * The template file that is used for this view.
     *
     * @var null
     */
    private $template = null;

    /**
     * This creates a view. Only the name of the template needs to be
     * given. The path is resolved automatically. The templates need to
     * be placed inside of the Views directory. Templates from sub-directories
     * can be declared with a dot. e.g. posts.index would load the template
     * file index.php inside of the posts directory in the Views directory.
     *
     * @param $template
     */
    public function __construct($template)
    {
        $template = implode("/", explode(".", $template));
        $this->template = __ROOT__ . "Views/" . $template . ".php";
    }

    /**
     * Magic methods so you can assign data directly to the view as
     * if they were class properties.
     *
     * @param $name
     * @param $value
     * @return $this
     */
    public function __set($name, $value)
    {
        $this->data[$name] = $value;
        return $this;
    }

    /**
     * Assign a variable to the view
     *
     * @param $name
     * @param $value
     * @return $this
     */
    public function assign($name, $value) {
        $this->data[$name] = $value;
        return $this;
    }

    /**
     * Get a property from the view.
     *
     * @param $name
     * @return null
     */
    public function __get($name)
    {
        if (!array_key_exists($name, $this->data)) {
            return null;
        }

        return $this->data[$name];
    }

    /**
     * Renders the view
     */
    public function render()
    {
        extract($this->data);
        ob_start();
        require_once($this->template);
        echo ob_get_clean();
        return true;
    }


}