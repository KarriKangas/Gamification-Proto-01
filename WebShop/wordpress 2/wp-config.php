<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', 'wordpress_gamification');

/** MySQL database username */
define('DB_USER', 'root');

/** MySQL database password */
define('DB_PASSWORD', 'root');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8mb4');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         'o|xS9Ibj&nux5`89ziE6ap.X9KwU[p9feonn3q}tkZ#:*I^g(8zf-*n[*K)Imn`X');
define('SECURE_AUTH_KEY',  'uTg*T6nu[~a-@gBAIp]urErS14m#MLSKQa^|SxnU2Lp<7dNXX^H7P=/ptARt60V|');
define('LOGGED_IN_KEY',    ')C<_ [;^>Q:rQd04~#pXDMwb|B8am<j#WW:^hO|y_ILsT#s`~x 35:qF#WN1Jb> ');
define('NONCE_KEY',        '><r2Qk*e>+-4>[bsS;1PG4[;^q|09wc9+OlnnK}cEiyB5Z8~> `K5[y)KG~zih({');
define('AUTH_SALT',        'iv0xL|H=Ak+v2}P<!)6P*S;JGG5[2LT*-_G8K;Mc<`LMaILEYx!`<-/A@@;Y.]7y');
define('SECURE_AUTH_SALT', 'WE&Ng(6hD:!lcQ,|cFrb-TZ2Cvaz5ZYpBSOm`pzERTbr$5J1Uj;!dPKyEGCdd[v:');
define('LOGGED_IN_SALT',   '?E#X)/%?z^V..^pAu-g9@J!<^%PTr)vt+K~k]tn_?V,%1Zl]2nRa(fkasOu4@w2*');
define('NONCE_SALT',       'zL`gWAgpsJ-(63+jbF,[tF]_6>e`2cg)9 5*ngl.g52:w/Zc_7pp-#cK(_#PH=/s');

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);

/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
