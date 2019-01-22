using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class TetrisLogic
    {


        public void moveFigureRight(ref int[,] _gameFieldArray, ref int figureX1, ref int figureY1, ref int figureX2, ref int figureY2, ref int figureX3, ref int figureY3, ref int figureX4, ref int figureY4, int figureColor, int figureState) //Move generate figure right if it is possible 
        {
            if (isPossibleMoveRight(_gameFieldArray, figureX1, figureY1, figureX2, figureY2, figureX3, figureY3, figureX4, figureY4, figureColor, figureState))
            {
                if (figureState == 1 || figureState == 4)
                {
                    if (figureX4 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY4, figureX4 + 1] == 0)
                        {
                            figureX4++;
                            _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4, figureX4 - 1];
                            _gameFieldArray[figureY4, figureX4 - 1] = 0;
                        }
                    if (figureX3 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY3, figureX3 + 1] == 0)
                        {
                            figureX3++;
                            _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3, figureX3 - 1];
                            _gameFieldArray[figureY3, figureX3 - 1] = 0;
                        }
                    if (figureX2 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY2, figureX2 + 1] == 0)
                        {
                            figureX2++;
                            _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2, figureX2 - 1];
                            _gameFieldArray[figureY2, figureX2 - 1] = 0;
                        }
                    if (figureX1 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY1, figureX1 + 1] == 0)
                        {
                            figureX1++;
                            _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1, figureX1 - 1];
                            _gameFieldArray[figureY1, figureX1 - 1] = 0;
                        }
                }


                if (figureState == 2 || figureState == 3)
                {
                    if (figureX1 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY1, figureX1 + 1] == 0)
                        {
                            figureX1++;
                            _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1, figureX1 - 1];
                            _gameFieldArray[figureY1, figureX1 - 1] = 0;
                        }
                    if (figureX2 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY2, figureX2 + 1] == 0)
                        {
                            figureX2++;
                            _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2, figureX2 - 1];
                            _gameFieldArray[figureY2, figureX2 - 1] = 0;
                        }
                    if (figureX3 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY3, figureX3 + 1] == 0)
                        {
                            figureX3++;
                            _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3, figureX3 - 1];
                            _gameFieldArray[figureY3, figureX3 - 1] = 0;
                        }
                    if (figureX4 + 1 < _gameFieldArray.GetLength(1))
                        if (_gameFieldArray[figureY4, figureX4 + 1] == 0)
                        {
                            figureX4++;
                            _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4, figureX4 - 1];
                            _gameFieldArray[figureY4, figureX4 - 1] = 0;
                        }
                }
            }
        }

        private bool isPossibleMoveRight(int[,] __gameFieldArray, int _figureX1, int _figureY1, int _figureX2, int _figureY2, int _figureX3, int _figureY3, int _figureX4, int _figureY4, int _figureColor, int _figureState)
        {
            bool response = false;

            switch (_figureColor)
            {
                case 1:
                    {
                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;
                        break;
                    }
                case 2:
                    {
                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;
                        break;
                    }
                case 3:
                    {

                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        break;
                    }
                case 4:
                    {
                        if (_figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX4 + 1 < __gameFieldArray.GetLength(1))
                            if (__gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY4, _figureX4 + 1] == 0)
                                response = true;
                        break;
                    }
                case 5:
                    {
                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX3 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX3 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        break;
                    }
                case 6:
                    {
                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY2, _figureX2 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;
                        break;
                    }
                case 7:
                    {
                        if (_figureState == 1)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX2 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0 && __gameFieldArray[_figureY2, _figureX2 + 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX3 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX4 + 1 < __gameFieldArray.GetLength(1) && _figureX1 + 1 < __gameFieldArray.GetLength(1) && _figureX3 + 1 < __gameFieldArray.GetLength(1))
                                if (__gameFieldArray[_figureY4, _figureX4 + 1] == 0 && __gameFieldArray[_figureY3, _figureX3 + 1] == 0 && __gameFieldArray[_figureY1, _figureX1 + 1] == 0)
                                    response = true;
                        break;
                    }
            }

            return response;
        }

        public void moveFigureLeft(ref int[,] _gameFieldArray, ref int figureX1, ref int figureY1, ref int figureX2, ref int figureY2, ref int figureX3, ref int figureY3, ref int figureX4, ref int figureY4, int figureColor, int figureState) //Move generate figure left if it is possible 
        {
            if (isPossibleMoveLeft(_gameFieldArray, figureX1, figureY1, figureX2, figureY2, figureX3, figureY3, figureX4, figureY4, figureColor, figureState))
            {
                if (figureState == 1 || figureState == 4)
                {
                    if (figureX1 - 1 >= 0)
                        if (_gameFieldArray[figureY1, figureX1 - 1] == 0)
                        {
                            figureX1--;
                            _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1, figureX1 + 1];
                            _gameFieldArray[figureY1, figureX1 + 1] = 0;
                        }
                    if (figureX2 - 1 >= 0)
                        if (_gameFieldArray[figureY2, figureX2 - 1] == 0)
                        {
                            figureX2--;
                            _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2, figureX2 + 1];
                            _gameFieldArray[figureY2, figureX2 + 1] = 0;
                        }
                    if (figureX3 - 1 >= 0)
                        if (_gameFieldArray[figureY3, figureX3 - 1] == 0)
                        {
                            figureX3--;
                            _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3, figureX3 + 1];
                            _gameFieldArray[figureY3, figureX3 + 1] = 0;
                        }
                    if (figureX4 - 1 >= 0)
                        if (_gameFieldArray[figureY4, figureX4 - 1] == 0)
                        {
                            figureX4--;
                            _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4, figureX4 + 1];
                            _gameFieldArray[figureY4, figureX4 + 1] = 0;
                        }
                }

                if (figureState == 2 || figureState == 3)
                {
                    if (figureX4 - 1 >= 0)
                        if (_gameFieldArray[figureY4, figureX4 - 1] == 0)
                        {
                            figureX4--;
                            _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4, figureX4 + 1];
                            _gameFieldArray[figureY4, figureX4 + 1] = 0;
                        }

                    if (figureX3 - 1 >= 0)
                        if (_gameFieldArray[figureY3, figureX3 - 1] == 0)
                        {
                            figureX3--;
                            _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3, figureX3 + 1];
                            _gameFieldArray[figureY3, figureX3 + 1] = 0;
                        }

                    if (figureX2 - 1 >= 0)
                        if (_gameFieldArray[figureY2, figureX2 - 1] == 0)
                        {
                            figureX2--;
                            _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2, figureX2 + 1];
                            _gameFieldArray[figureY2, figureX2 + 1] = 0;
                        }

                    if (figureX1 - 1 >= 0)
                        if (_gameFieldArray[figureY1, figureX1 - 1] == 0)
                        {
                            figureX1--;
                            _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1, figureX1 + 1];
                            _gameFieldArray[figureY1, figureX1 + 1] = 0;
                        }
                }
            }
        }

        private bool isPossibleMoveLeft(int[,] __gameFieldArray, int _figureX1, int _figureY1, int _figureX2, int _figureY2, int _figureX3, int _figureY3, int _figureX4, int _figureY4, int _figureColor, int _figureState)
        {
            bool response = false;

            switch (_figureColor)
            {
                case 1:
                    {
                        if (_figureState == 1)
                            if (_figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;
                        if (_figureState == 2)
                            if (_figureX1 - 1 >= 0 && _figureX2 - 1 >= 0 && _figureX3 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                                    response = true;
                        break;
                    }
                case 2:
                    {
                        if (_figureState == 1)
                            if (_figureX1 - 1 >= 0 && _figureX2 - 1 >= 0)
                                if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY2, _figureX2 - 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX3 - 1 >= 0 && _figureX2 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX4 - 1 >= 0 && _figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY4, _figureX4 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        if (_figureState == 4)
                            if (_figureX3 - 1 >= 0 && _figureX1 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                                    response = true;

                        break;
                    }
                case 3:
                    {
                        if (_figureState == 1)
                            if (_figureX2 - 1 >= 0 && _figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX2 - 1 >= 0 && _figureX3 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                                    response = true;

                        if (_figureState == 3)
                            if (_figureX1 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                            response = true;

                        if (_figureState == 4)
                            if (_figureX2 - 1 >= 0 && _figureX3 - 1 >= 0 && _figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                            response = true;

                        break;
                    }
                case 4:
                    {
                        if (_figureX1 - 1 >= 0 && _figureX3 - 1 >= 0)
                            if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0)
                                response = true;
                        break;
                    }
                case 5:
                    {
                        if (_figureState == 1)
                            if (_figureX3 - 1 >= 0)
                                if (__gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX3 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                            response = true;

                        break;
                    }
                case 6:
                    {
                        if (_figureState == 1) 
                            if (_figureX2 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX2 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX2 - 1 >= 0 && _figureX3 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX3 - 1] == 0 && __gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                            response = true;

                        if (_figureState == 3)
                            if (_figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0) 
                            response = true;

                        if (_figureState == 4)
                            if (_figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY2, _figureX3 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0)
                            response = true;

                        break;
                    }
                case 7:
                    {
                        if (_figureState == 1)
                            if (_figureX3 - 1 >= 0 && _figureX1 - 1 >= 0)
                                if (__gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        if (_figureState == 2)
                            if (_figureX3 - 1 >= 0 && _figureX4 - 1 >= 0)
                                if (__gameFieldArray[_figureY3, _figureX3 - 1] == 0 && __gameFieldArray[_figureY4, _figureX4 - 1] == 0 && __gameFieldArray[_figureY1, _figureX1 - 1] == 0)
                                    response = true;

                        break;
                    }
            }

            return response;
        }

        public void moveFigureDown(ref int[,] _gameFieldArray, ref int figureX1, ref int figureY1, ref int figureX2, ref int figureY2, ref int figureX3, ref int figureY3, ref int figureX4, ref int figureY4, int figureState) //Move generate figure down if it is possible 
        {
            if (figureState == 1 || figureState == 2)
            {
                figureY4++;
                _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4 - 1, figureX4];
                _gameFieldArray[figureY4 - 1, figureX4] = 0;

                figureY3++;
                _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3 - 1, figureX3];
                _gameFieldArray[figureY3 - 1, figureX3] = 0;

                figureY2++;
                _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2 - 1, figureX2];
                _gameFieldArray[figureY2 - 1, figureX2] = 0;

                figureY1++;
                _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1 - 1, figureX1];
                _gameFieldArray[figureY1 - 1, figureX1] = 0;
            }

            if (figureState == 3 || figureState == 4)
            {
                figureY1++;
                _gameFieldArray[figureY1, figureX1] = _gameFieldArray[figureY1 - 1, figureX1];
                _gameFieldArray[figureY1 - 1, figureX1] = 0;

                figureY2++;
                _gameFieldArray[figureY2, figureX2] = _gameFieldArray[figureY2 - 1, figureX2];
                _gameFieldArray[figureY2 - 1, figureX2] = 0;

                figureY3++;
                _gameFieldArray[figureY3, figureX3] = _gameFieldArray[figureY3 - 1, figureX3];
                _gameFieldArray[figureY3 - 1, figureX3] = 0;

                figureY4++;
                _gameFieldArray[figureY4, figureX4] = _gameFieldArray[figureY4 - 1, figureX4];
                _gameFieldArray[figureY4 - 1, figureX4] = 0;                
            }
        }

        public void figureGenerating(ref int[,] _gameFieldArray, out int figureX1, out int figureY1, out int figureX2, out int figureY2, out int figureX3, out int figureY3, out int figureX4, out int figureY4, out int figureColor, out int figureState) //Generates one of seven different figures by random
        {
            figureState = 1;

            Random rand = new Random();
            int randFigureChoose = rand.Next(1, 8);

            switch (randFigureChoose)
            {
                case 1: // Blue
                    {
                        figureColor = 1;

                        figureX1 = 3;
                        figureX2 = 4;
                        figureX3 = 5;
                        figureX4 = 6;

                        figureY1 = 1;
                        figureY2 = 1;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[1, 3] = 1;
                        _gameFieldArray[1, 4] = 1;
                        _gameFieldArray[1, 5] = 1;
                        _gameFieldArray[1, 6] = 1;

                        break;
                    }

                case 2: // DarkBlue
                    {
                        figureColor = 2;

                        figureX1 = 3;
                        figureX2 = 3;
                        figureX3 = 4;
                        figureX4 = 5;

                        figureY1 = 0;
                        figureY2 = 1;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 3] = 2;
                        _gameFieldArray[1, 3] = 2;
                        _gameFieldArray[1, 4] = 2;
                        _gameFieldArray[1, 5] = 2;

                        break;
                    }

                case 3: // Orange
                    {
                        figureColor = 3;

                        figureX1 = 6;
                        figureX2 = 4;
                        figureX3 = 5;
                        figureX4 = 6;

                        figureY1 = 0;
                        figureY2 = 1;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 6] = 3;
                        _gameFieldArray[1, 4] = 3;
                        _gameFieldArray[1, 5] = 3;
                        _gameFieldArray[1, 6] = 3;

                        break;
                    }

                case 4: // Yellow
                    {
                        figureColor = 4;

                        figureX1 = 4;
                        figureX2 = 5;
                        figureX3 = 4;
                        figureX4 = 5;

                        figureY1 = 0;
                        figureY2 = 0;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 4] = 4;
                        _gameFieldArray[0, 5] = 4;
                        _gameFieldArray[1, 4] = 4;
                        _gameFieldArray[1, 5] = 4;

                        break;
                    }

                case 5: // Green
                    {
                        figureColor = 5;

                        figureX1 = 4;
                        figureX2 = 5;
                        figureX3 = 3;
                        figureX4 = 4;

                        figureY1 = 0;
                        figureY2 = 0;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 4] = 5;
                        _gameFieldArray[0, 5] = 5;
                        _gameFieldArray[1, 3] = 5;
                        _gameFieldArray[1, 4] = 5;

                        break;
                    }

                case 6: // Purple
                    {
                        figureColor = 6;

                        figureX1 = 4;
                        figureX2 = 3;
                        figureX3 = 4;
                        figureX4 = 5;

                        figureY1 = 0;
                        figureY2 = 1;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 4] = 6;
                        _gameFieldArray[1, 3] = 6;
                        _gameFieldArray[1, 4] = 6;
                        _gameFieldArray[1, 5] = 6;

                        break;
                    }

                case 7: // Red
                    {
                        figureColor = 7;

                        figureX1 = 3;
                        figureX2 = 4;
                        figureX3 = 4;
                        figureX4 = 5;

                        figureY1 = 0;
                        figureY2 = 0;
                        figureY3 = 1;
                        figureY4 = 1;

                        _gameFieldArray[0, 3] = 7;
                        _gameFieldArray[0, 4] = 7;
                        _gameFieldArray[1, 4] = 7;
                        _gameFieldArray[1, 5] = 7;

                        break;
                    }
                default:
                    {
                        figureColor = 0;

                        figureX1 = 0;
                        figureX2 = 0;
                        figureX3 = 0;
                        figureX4 = 0;

                        figureY1 = 0;
                        figureY2 = 0;
                        figureY3 = 0;
                        figureY4 = 0;
                        break;
                    }
            }
        }

        public bool isComeDownPossible(int[,] _gameFieldArray, int figureX1, int figureY1, int figureX2, int figureY2, int figureX3, int figureY3, int figureX4, int figureY4, int figureColor, int figureState)
        {
            bool response = false;

            switch (figureColor)
            {
                case 1: // Blue
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;
                        if (figureState == 2)
                            if (_gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;
                        break;
                    }

                case 2: // DarkBlue
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 2)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 3)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 4)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY2 + 1, figureX2] == 0)
                                response = true;

                        break;
                    }

                case 3: // Orange
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 2)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 3)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0)
                                response = true;

                        if (figureState == 4)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0)
                                response = true;
                        break;
                    }

                case 4: // Yellow
                    {
                        if (_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                            response = true;
                        break;
                    }

                case 5: // Green
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 2)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 3)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0)
                                response = true;

                        if (figureState == 4)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0)
                                response = true;

                        break;
                    }

                case 6: // Purple
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;
                        if (figureState == 3)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;
                        if (figureState == 2)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;
                        if (figureState == 4)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0)
                                response = true;
                        break;
                    }

                case 7: // Red
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 2)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0)
                                response = true;

                        if (figureState == 3)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY4 + 1, figureX4] == 0 && _gameFieldArray[figureY1 + 1, figureX1] == 0)
                                response = true;

                        if (figureState == 4)
                            if (_gameFieldArray[figureY1 + 1, figureX1] == 0 && _gameFieldArray[figureY3 + 1, figureX3] == 0)
                                response = true;

                        break;
                    }
            }

            return response;
        }

        public void rotateFigure(ref int[,] _gameFieldArray, ref int figureX1, ref int figureY1, ref int figureX2, ref int figureY2, ref int figureX3, ref int figureY3, ref int figureX4, ref int figureY4, int figureColor, ref int figureState)
        {
            switch (figureColor)  // checking if is the rotation possible in current place for each color and state
            {
                case 1:
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY2 + 1, figureX2] == 0 && _gameFieldArray[figureY2 + 2, figureX2] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX1 = figureX2;
                                figureX3 = figureX2;
                                figureX4 = figureX2;

                                figureY1 = figureY2 - 1;
                                figureY3 = figureY2 + 1;
                                figureY4 = figureY2 + 2;

                                _gameFieldArray[figureY1, figureX1] = 1;
                                _gameFieldArray[figureY2, figureX2] = 1;
                                _gameFieldArray[figureY3, figureX3] = 1;
                                _gameFieldArray[figureY4, figureX4] = 1;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2)
                            if (figureX2 > 0 && figureX2 < _gameFieldArray.GetLength(1) - 2 && _gameFieldArray[figureY2, figureX2 - 1] == 0 && _gameFieldArray[figureY2, figureX2 + 1] == 0 && _gameFieldArray[figureY2, figureX2 + 2] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX1 = figureX2 - 1;
                                figureX3 = figureX2 + 1;
                                figureX4 = figureX2 + 2;

                                figureY1 = figureY2;
                                figureY3 = figureY2;
                                figureY4 = figureY2;

                                _gameFieldArray[figureY1, figureX1] = 1;
                                _gameFieldArray[figureY2, figureX2] = 1;
                                _gameFieldArray[figureY3, figureX3] = 1;
                                _gameFieldArray[figureY4, figureX4] = 1;

                                figureState = 1;
                            }
                        break;
                    }
                case 2:
                    {
                        if (figureState == 1 && figureX3 < _gameFieldArray.GetLength(1) - 1)
                            if (_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY3 - 1, figureX3 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3;
                                figureX2 = figureX3;
                                figureX1 = figureX3 + 1;

                                figureY2 = figureY3 - 1;
                                figureY4 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 2;
                                _gameFieldArray[figureY2, figureX2] = 2;
                                _gameFieldArray[figureY3, figureX3] = 2;
                                _gameFieldArray[figureY4, figureX4] = 2;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2 && figureX3 > 0 && figureX3 < _gameFieldArray.GetLength(1) - 1)
                            if (_gameFieldArray[figureY3, figureX3 - 1] == 0 && _gameFieldArray[figureY3 + 1, figureX3 + 1] == 0 && _gameFieldArray[figureY3, figureX3 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3 - 1;
                                figureX2 = figureX3 + 1;

                                figureY2 = figureY3;
                                figureY4 = figureY3;
                                figureY1 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 2;
                                _gameFieldArray[figureY2, figureX2] = 2;
                                _gameFieldArray[figureY3, figureX3] = 2;
                                _gameFieldArray[figureY4, figureX4] = 2;

                                figureState = 3;
                                break;
                            }
                        if (figureState == 3 && figureX3 > 0)
                            if (_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY3 + 1, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3;
                                figureX2 = figureX3;
                                figureX1 = figureX3 - 1;

                                figureY4 = figureY2 - 1;
                                figureY2 = figureY2 + 1;
                                figureY1 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 2;
                                _gameFieldArray[figureY2, figureX2] = 2;
                                _gameFieldArray[figureY3, figureX3] = 2;
                                _gameFieldArray[figureY4, figureX4] = 2;

                                figureState = 4;
                                break;
                            }
                        if (figureState == 4 && figureX3 < _gameFieldArray.GetLength(1) - 1)
                            if (_gameFieldArray[figureY3, figureX2 + 1] == 0 && _gameFieldArray[figureY3, figureX3 + 1] == 0 && _gameFieldArray[figureY3, figureX3 - 1] == 0 && _gameFieldArray[figureY3 - 1, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3 + 1;
                                figureX2 = figureX3 - 1;
                                figureX1 = figureX3 - 1;

                                figureY2 = figureY3;
                                figureY4 = figureY3;
                                figureY1 = figureY3 - 1;

                                _gameFieldArray[figureY1, figureX1] = 2;
                                _gameFieldArray[figureY2, figureX2] = 2;
                                _gameFieldArray[figureY3, figureX3] = 2;
                                _gameFieldArray[figureY4, figureX4] = 2;

                                figureState = 1;
                            }
                        break;
                    }
                case 3:
                    {
                        if (figureState == 1)
                            if(_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY3 + 1, figureX3 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3;
                                figureX4 = figureX3;

                                figureY4 = figureY3 + 1;
                                figureY2 = figureY3 - 1;
                                figureY1 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 3;
                                _gameFieldArray[figureY2, figureX2] = 3;
                                _gameFieldArray[figureY3, figureX3] = 3;
                                _gameFieldArray[figureY4, figureX4] = 3;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2 && figureX3 - 1 >= 0)
                            if (_gameFieldArray[figureY3 + 1, figureX3 - 1] == 0 && _gameFieldArray[figureY3, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3 + 1;
                                figureX4 = figureX3 - 1;
                                figureX1 = figureX3 - 1;

                                figureY2 = figureY3;
                                figureY4 = figureY3;

                                _gameFieldArray[figureY1, figureX1] = 3;
                                _gameFieldArray[figureY2, figureX2] = 3;
                                _gameFieldArray[figureY3, figureX3] = 3;
                                _gameFieldArray[figureY4, figureX4] = 3;

                                figureState = 3;
                                break;
                            }
                        if (figureState == 3)
                                if (_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY3 - 1, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3;
                                figureX1 = figureX3 - 1;
                                figureX2 = figureX3;

                                figureY4 = figureY3 - 1;
                                figureY1 = figureY3 - 1;
                                figureY2 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 3;
                                _gameFieldArray[figureY2, figureX2] = 3;
                                _gameFieldArray[figureY3, figureX3] = 3;
                                _gameFieldArray[figureY4, figureX4] = 3;

                                figureState = 4;
                                break;
                            }
                        if (figureState == 4 && figureX3 < _gameFieldArray.GetLength(1) - 1)
                            if (_gameFieldArray[figureY3, figureX3 + 1] == 0 && _gameFieldArray[figureY3 - 1, figureX3 + 1] == 0 && _gameFieldArray[figureY3, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3 - 1;
                                figureX4 = figureX3 + 1;
                                figureX1 = figureX3 + 1;

                                figureY4 = figureY3;
                                figureY2 = figureY3;

                                _gameFieldArray[figureY1, figureX1] = 3;
                                _gameFieldArray[figureY2, figureX2] = 3;
                                _gameFieldArray[figureY3, figureX3] = 3;
                                _gameFieldArray[figureY4, figureX4] = 3;

                                figureState = 1;
                            }

                        break;
                    }
                case 5:
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY4 + 1, figureX4 + 1] == 0 && _gameFieldArray[figureY4, figureX4 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX1 = figureX4 + 1;
                                figureX3 = figureX4;

                                figureY3 = figureY4 - 1;
                                figureY2 = figureY4 + 1;
                                figureY1 = figureY4;

                                _gameFieldArray[figureY1, figureX1] = 5;
                                _gameFieldArray[figureY2, figureX2] = 5;
                                _gameFieldArray[figureY3, figureX3] = 5;
                                _gameFieldArray[figureY4, figureX4] = 5;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2 && figureX4 - 1 >= 0)
                            if (_gameFieldArray[figureY4 + 1, figureX4] == 0 && _gameFieldArray[figureY4 + 1, figureX4 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX3 = figureX4 - 1;
                                figureX1 = figureX4;

                                figureY1 = figureY4 - 1;
                                figureY2 = figureY4 - 1;
                                figureY3 = figureY4;

                                _gameFieldArray[figureY1, figureX1] = 5;
                                _gameFieldArray[figureY2, figureX2] = 5;
                                _gameFieldArray[figureY3, figureX3] = 5;
                                _gameFieldArray[figureY4, figureX4] = 5;

                                figureState = 1;
                            }
                        break;
                    }
                case 6:
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY3 + 1, figureX3] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3;
                                figureX4 = figureX3;
                                figureX1 = figureX3 + 1;

                                figureY4 = figureY3 + 1;
                                figureY2 = figureY3 - 1;
                                figureY1 = figureY3;

                                _gameFieldArray[figureY1, figureX1] = 6;
                                _gameFieldArray[figureY2, figureX2] = 6;
                                _gameFieldArray[figureY3, figureX3] = 6;
                                _gameFieldArray[figureY4, figureX4] = 6;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2 && figureX3 - 1 >= 0)
                            if (_gameFieldArray[figureY3, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3 + 1;
                                figureX4 = figureX3 - 1;
                                figureX1 = figureX3;

                                figureY2 = figureY3;
                                figureY4 = figureY3;
                                figureY1 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 6;
                                _gameFieldArray[figureY2, figureX2] = 6;
                                _gameFieldArray[figureY3, figureX3] = 6;
                                _gameFieldArray[figureY4, figureX4] = 6;

                                figureState = 3;
                                break;
                            }
                        if (figureState == 3)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX4 = figureX3;
                                figureX1 = figureX3 - 1;
                                figureX2 = figureX3;

                                figureY4 = figureY3 - 1;
                                figureY1 = figureY3;
                                figureY2 = figureY3 + 1;

                                _gameFieldArray[figureY1, figureX1] = 6;
                                _gameFieldArray[figureY2, figureX2] = 6;
                                _gameFieldArray[figureY3, figureX3] = 6;
                                _gameFieldArray[figureY4, figureX4] = 6;

                                figureState = 4;
                                break;
                            }
                        if (figureState == 4 && figureX3 < _gameFieldArray.GetLength(1) - 1)
                            if (_gameFieldArray[figureY3, figureX3 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3 - 1;
                                figureX4 = figureX3 + 1;
                                figureX1 = figureX3;

                                figureY4 = figureY3;
                                figureY2 = figureY3;
                                figureY1 = figureY3 - 1;

                                _gameFieldArray[figureY1, figureX1] = 6;
                                _gameFieldArray[figureY2, figureX2] = 6;
                                _gameFieldArray[figureY3, figureX3] = 6;
                                _gameFieldArray[figureY4, figureX4] = 6;

                                figureState = 1;
                            }

                        break;
                    }
                case 7:
                    {
                        if (figureState == 1)
                            if (_gameFieldArray[figureY3 + 1, figureX3] == 0 && _gameFieldArray[figureY3 - 1, figureX3 + 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX1 = figureX3 + 1;
                                figureX2 = figureX3 + 1;
                                figureX4 = figureX3;

                                figureY4 = figureY3 + 1;
                                figureY2 = figureY3;

                                _gameFieldArray[figureY1, figureX1] = 7;
                                _gameFieldArray[figureY2, figureX2] = 7;
                                _gameFieldArray[figureY3, figureX3] = 7;
                                _gameFieldArray[figureY4, figureX4] = 7;

                                figureState = 2;
                                break;
                            }
                        if (figureState == 2 && figureX3 - 1 >= 0)
                            if (_gameFieldArray[figureY3 - 1, figureX3 - 1] == 0)
                            {
                                _gameFieldArray[figureY1, figureX1] = 0;
                                _gameFieldArray[figureY2, figureX2] = 0;
                                _gameFieldArray[figureY3, figureX3] = 0;
                                _gameFieldArray[figureY4, figureX4] = 0;

                                figureX2 = figureX3;
                                figureX1 = figureX3 - 1;
                                figureX4 = figureX3 + 1;

                                figureY2 = figureY3 - 1;
                                figureY4 = figureY3;

                                _gameFieldArray[figureY1, figureX1] = 7;
                                _gameFieldArray[figureY2, figureX2] = 7;
                                _gameFieldArray[figureY3, figureX3] = 7;
                                _gameFieldArray[figureY4, figureX4] = 7;

                                figureState = 1;
                            }
                        break;
                    }
            }
        }
    }
}