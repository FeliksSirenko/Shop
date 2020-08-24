const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const postcssPresetEnv = require('postcss-preset-env');

const devMode = process.env.NODE_ENV !== 'production';
module.exports = {
    mode: devMode ? 'development' : 'production',
    entry: {
        css: './Styles/site.scss',
        site: './Scripts/site.js'
    },
    output: {
        path: path.resolve(__dirname, 'wwwroot'),
        publicPath: '/css',
        filename: 'js/[name].js'
    },
    devtool: devMode ? 'inline-source-map' : 'source-map',
    module: {
        rules: [
            {
                test: /\.(js)$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            },
            {
                test: /\.(sa|sc)ss$/,
                use: [
                    {
                        loader: MiniCssExtractPlugin.loader
                    },
                    {
                        loader: 'css-loader',
                        options: {
                            importLoaders: 2
                        }
                    },
                    {
                        loader: 'postcss-loader',
                        options: {
                            ident: 'postcss',
                            plugins: devMode
                                ? () => []
                                : () => [
                                    postcssPresetEnv({
                                        browsers: ['>0.2%', 'not dead', 'not ie < 10', 'not op_mini all']
                                    }),
                                    require('cssnano')()
                                ]
                        }
                    },
                    {
                        loader: 'sass-loader'
                    }
                ]
            },
            {
                test: /\.(png|jpe?g|gif)$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].[ext]',
                            publicPath: '../images',
                            emitFile: false
                        }
                    }
                ]
            }
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({
            filename: devMode ? 'css/site.css' : 'css/site.min.css'
        })
    ]
};