<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInit70c79dc1e83174daaddf37f1df19f4bd
{
    public static $prefixLengthsPsr4 = array (
        'M' => 
        array (
            'MathPHP\\' => 8,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'MathPHP\\' => 
        array (
            0 => __DIR__ . '/..' . '/markrogoyski/math-php/src',
        ),
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInit70c79dc1e83174daaddf37f1df19f4bd::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInit70c79dc1e83174daaddf37f1df19f4bd::$prefixDirsPsr4;

        }, null, ClassLoader::class);
    }
}
